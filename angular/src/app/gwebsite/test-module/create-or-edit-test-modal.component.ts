import { Component, ElementRef, EventEmitter, Injector, Output, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { ModalDirective } from 'ngx-bootstrap';
import { finalize } from 'rxjs/operators';
import { TestModuleDto } from '@app/gwebsite/test-module/dto/test.dto';
import { WebApiServiceProxy } from '@shared/service-proxies/webapi.service';
import { ComboboxItemDto } from '@shared/service-proxies/service-proxies';

@Component({
    selector: 'createOrEditTestModuleModal',
    templateUrl: './create-or-edit-test-modal.component.html'
})
export class CreateOrEditTestModuleModalComponent extends AppComponentBase {

    @ViewChild('createOrEditModal') modal: ModalDirective;
    @ViewChild('testModuleCombobox') testModuleCombobox: ElementRef;
    @ViewChild('iconCombobox') iconCombobox: ElementRef;

    /**
     * @Output dùng để public event cho component khác xử lý
     */
    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active = false;
    saving = false;

    testModule: TestModuleDto = new TestModuleDto();
    testModules: ComboboxItemDto[] = [];

    constructor(
        injector: Injector,
        private _apiService: WebApiServiceProxy
    ) {
        super(injector);
    }

    show(testModuleId?: number | null | undefined): void {
        this.active = true;

        this._apiService.getForEdit('api/TestModel/GetTestModelForEdit', testModuleId).subscribe(result => {
            this.testModule = result.testModule;
            this.testModules = result.testModules;
            this.modal.show();
            setTimeout(() => {
                    $(this.testModuleCombobox.nativeElement).selectpicker('refresh');
            }, 0);
        });
    }

    save(): void {
        let input = this.testModule;
        this.saving = true;
        if (input.id) {
            this.updateTestModule();
        } else {
            this.insertTestModule();
        }
    }

    insertTestModule() {
        this._apiService.post('api/TestModel/CreateOrEditTestModel', this.testModule)
            .pipe(finalize(() => this.saving = false))
            .subscribe(() => {
                this.notify.info(this.l('SavedSuccessfully'));
                this.close();
                this.modalSave.emit(null);
            });
    }

    updateTestModule() {
        this._apiService.put('api/TestModel/CreateOrEditTestModel', this.testModule)
            .pipe(finalize(() => this.saving = false))
            .subscribe(() => {
                this.notify.info(this.l('SavedSuccessfully'));
                this.close();
                this.modalSave.emit(null);
            });
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }
}
