import {
    Component,
    ElementRef,
    EventEmitter,
    Injector,
    Output,
    ViewChild
} from "@angular/core";
import { AppComponentBase } from "@shared/common/app-component-base";
import { ModalDirective } from "ngx-bootstrap";
import { finalize } from "rxjs/operators";
import { DepreciationModel } from "@app/gwebsite/models/depreciation.model";
import { WebApiServiceProxy } from "@shared/service-proxies/webapi.service";
import { ComboboxItemDto } from "@shared/service-proxies/service-proxies";

@Component({
    selector: "app-create-or-edit-depreciation",
    templateUrl: "./create-or-edit-depreciation.component.html",
    styleUrls: ["./create-or-edit-depreciation.component.css"]
})
export class CreateOrEditDepreciationComponent extends AppComponentBase {
    @ViewChild("createOrEditModal") modal: ModalDirective;
    @ViewChild("depreciationCombobox") depreciationCombobox: ElementRef;
    @ViewChild("departmentCombobox") departmentCombobox: ElementRef;
    @ViewChild("methodCombobox") methodCombobox: ElementRef;
    @ViewChild("iconCombobox") iconCombobox: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active = false;
    saving = false;

    depreciation: DepreciationModel = new DepreciationModel();
    depreciations: DepreciationModel[] = [];

    assets = [
        'Dell XPS 13 2019',
        'Macbook Pro 13 2019',
        'Macbook Pro 15 2019',
        'Macbook Air 2019'
    ];

    departments = [
        'Z Team',
        'Koi company',
        'Ting Group'
    ];

    methods = [
        'Khấu hao đường thẳng',
        'Khấu hao theo số dư giảm dần có điểu chỉnh'
    ];


    constructor(injector: Injector, private _apiService: WebApiServiceProxy) {
        super(injector);
    }

    show(id?: number | null | undefined): void {
        this.active = true;

        this._apiService
            .getForEdit("api/Depreciation/GetDepreciationForEdit", id)
            .subscribe(result => {
                this.depreciation = result.depreciation;
                this.depreciations = result.depreciations;
                this.modal.show();
                setTimeout(() => {
                    $(this.depreciationCombobox.nativeElement).selectpicker(
                        "refresh"
                    );
                    $(this.departmentCombobox.nativeElement).selectpicker("refresh");
                    $(this.methodCombobox.nativeElement).selectpicker('refresh');
                }, 0);
                this.calculateDepreciation();
            });
    }

    save(): void {
        let input = this.depreciation;
        this.saving = true;
        if (input.id) {
            this.updateDepreciation();
        } else {
            this.insertDepreciation();
        }
    }

    insertDepreciation() {
        this._apiService
            .post("api/Depreciation/CreateDepreciation", this.depreciation)
            .pipe(finalize(() => (this.saving = false)))
            .subscribe(() => {
                this.notify.info(this.l("SavedSuccessfully"));
                this.close();
                this.modalSave.emit(null);
            });
    }

    updateDepreciation() {
        this._apiService
            .put("api/Depreciation/UpdateDepreciation", this.depreciation)
            .pipe(finalize(() => (this.saving = false)))
            .subscribe(() => {
                this.notify.info(this.l("SavedSuccessfully"));
                this.close();
                this.modalSave.emit(null);
            });
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }

    getDiffYear(first: Date, second: Date): number {
        return (second.getFullYear() - first.getFullYear()) + 1;
    }

    convertCorectTime(date: any) {
        const t = date.split('T')[0].split('-');
        return new Date(parseInt(t[0]), parseInt(t[1]), parseInt(t[2]));
    }

    calculateDepreciation(): void {
        switch (this.depreciation.calculationMethod) {
            case this.methods[0]:
                const totalYear = this.getDiffYear(
                    this.convertCorectTime(this.depreciation.dateOfStartCalculateDepreciation),
                    this.convertCorectTime(this.depreciation.expiryDate)
                );
                const depreciationEveryYear = Math.round(this.depreciation.originalPrice / totalYear);
                // Replace
                this.depreciation.depreciationValue = depreciationEveryYear * this.getDiffYear(
                    this.convertCorectTime(this.depreciation.dateOfStartCalculateDepreciation),
                    new Date(2019, 1, 1)
                );
                this.depreciation.annualDepreciationRate = 100 * depreciationEveryYear / this.depreciation.originalPrice;
                this.depreciation.monthlyDepreciationRate = Math.round(this.depreciation.annualDepreciationRate / 12);
                break;
            default:
                
        }
    }

    methodChangeValue() {
        this.calculateDepreciation();
    }

    originalPriceChangeValue() {
        this.calculateDepreciation();
    }
}
