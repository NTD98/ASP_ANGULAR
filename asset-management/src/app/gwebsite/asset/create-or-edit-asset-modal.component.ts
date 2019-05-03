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
import { WebApiServiceProxy } from "@shared/service-proxies/webapi.service";
import { ComboboxItemDto } from "@shared/service-proxies/service-proxies";
import { AssetDto } from "./dto/asset.dto";

@Component({
    selector: "create-or-edit-asset-modal",
    templateUrl: "./create-or-edit-asset-modal.component.html"
})
export class CreateOrEditAssetModalComponent extends AppComponentBase {
    @ViewChild("createOrEditModal") modal: ModalDirective;
    @ViewChild("assetCombobox") assetCombobox: ElementRef;
    @ViewChild("iconCombobox") iconCombobox: ElementRef;
    @ViewChild("depreciationCategoryCombobox") depreciationCategoryCombobox: ElementRef;

    /**
     * @Output dùng để public event cho component khác xử lý
     */
    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active = false;
    saving = false;
    assetCategories: ComboboxItemDto[] = [];
    depreciationCategory = [
        {id: 1, name: 'Khấu hao theo đường thẳng'},
        {id: 2, name: 'Khấu hao theo số dư giảm'},
        {id: 3, name: 'Khấu hao theo số lượng, khối lượng'}
    ];
    asset: AssetDto = new AssetDto();
    assets: ComboboxItemDto[] = [];

    constructor(injector: Injector, private _apiService: WebApiServiceProxy) {
        super(injector);
    }




    show(assetID?: number | null | undefined): void {
        this.active = true;

        this._apiService
            .getForEdit("api/Asset/GetAssetForEdit", assetID)
            .subscribe(result => {
                this.asset = result.asset;
                this.assets = result.assets;
                this.modal.show();
                setTimeout(() => {
                    $(this.assetCombobox.nativeElement).selectpicker("refresh");
                }, 0);
            });
        this._apiService
            .getForEdit("api/AssetCategory/GetAssetCategoryForEdit", 0)
            .subscribe(result => {
                this.assetCategories = result.assetCategories;
                this.modal.show();
                setTimeout(() => {
                    $(this.assetCombobox.nativeElement).selectpicker("refresh");
                }, 0);
            });
    }

    save(): void {
        let input = this.asset;
        this.saving = true;
        if (input.id) {
            this.updateAsset();
        } else {
            this.asset.id = 0;
            this.asset.categoryID = 1;
            this.asset.isDeleted = false;
            this.insertAsset();
        }
    }

    insertAsset() {
        //this.asset.dateCheckIn = new Date(Date.parse(this.asset.dateCheckIn)).toISOString();
        //this.asset.expiryDate = new Date(Date.parse(this.asset.expiryDate)).toISOString();
        this._apiService
            .post("api/Asset/CreateAsset", this.asset)
            .pipe(finalize(() => (this.saving = false)))
            .subscribe(() => {
                this.notify.info(this.l("SavedSuccessfully"));
                this.close();
                this.modalSave.emit(null);
            });
    }

    updateAsset() {
        this._apiService
            .put("api/Asset/UpdateAsset", this.asset)
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
}
