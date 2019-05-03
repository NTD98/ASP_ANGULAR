import {
    AfterViewInit,
    Component,
    ElementRef,
    Injector,
    OnInit,
    ViewChild
} from "@angular/core";
import { ActivatedRoute, Params, Router } from "@angular/router";
import { appModuleAnimation } from "@shared/animations/routerTransition";
import { AppComponentBase } from "@shared/common/app-component-base";
import * as _ from "lodash";
import { LazyLoadEvent } from "primeng/components/common/lazyloadevent";
import { Paginator } from "primeng/components/paginator/paginator";
import { Table } from "primeng/components/table/table";
import {
    WebApiServiceProxy,
    IFilter
} from "@shared/service-proxies/webapi.service";
import { CreateOrEditAssetModalComponent } from "./create-or-edit-asset-modal.component";
import { DatepickerModule } from "ngx-bootstrap";

@Component({
    templateUrl: "./asset.component.html",
    animations: [appModuleAnimation()]
})
export class AssetComponent extends AppComponentBase
    implements AfterViewInit, OnInit {
    /**
     * @ViewChild là dùng get control và call thuộc tính, functions của control đó
     */
    @ViewChild("textsTable") textsTable: ElementRef;
    @ViewChild("createOrEditModal")
    createOrEditModal: CreateOrEditAssetModalComponent;
    @ViewChild("dataTable") dataTable: Table;
    @ViewChild("paginator") paginator: Paginator;
    @ViewChild("dateCheckIn") dateCheckIn: DatepickerModule
    // @ViewChild("dateCheckIn") dateCheckIn: DatepickerModule
    // @ViewChild("dateCheckIn") dateCheckIn: DatepickerModule
    /**
     * tạo các biến dể filters
     */
    filterText: string;

    constructor(
        injector: Injector,
        private _router: Router,
        private _activatedRoute: ActivatedRoute,
        private _apiService: WebApiServiceProxy
    ) {
        super(injector);
    }

    /**
     * Hàm xử lý trước khi View được init
     */
    ngOnInit(): void {}

    /**
     * Hàm xử lý sau khi View được init
     */
    ngAfterViewInit(): void {
        setTimeout(() => {
            this.init();
        });
    }

    /**
     * Hàm get danh sách MenuClient
     * @param event
     */
    getAssets(event?: LazyLoadEvent) {
        if (!this.paginator || !this.dataTable) {
            return;
        }

        //show loading trong gridview
        this.primengTableHelper.showLoadingIndicator();

        /**
         * Sử dụng _apiService để call các api của backend
         */
        this._apiService
            .get(
                "api/Asset/GetAssetsByFilter",
                [{ fieldName: "Name", value: this.filterText }],
                this.primengTableHelper.getSorting(this.dataTable),
                this.primengTableHelper.getMaxResultCount(
                    this.paginator,
                    event
                ),
                this.primengTableHelper.getSkipCount(this.paginator, event)
            )
            .subscribe(result => {
                this.primengTableHelper.totalRecordsCount = result.totalCount;
                this.primengTableHelper.records = result.items;
                this.primengTableHelper.hideLoadingIndicator();
            });
    }

    delete(assetID?: number | null | undefined): void {
        this._apiService
            .delete("api/Asset/DeleteAsset/", assetID)
            .subscribe(result => {
                this.getAssets();
            })
    }

    init(): void {
        //get params từ url để thực hiện filter
        this._activatedRoute.params.subscribe((params: Params) => {
            this.filterText = params["filterText"] || "";
            //reload lại gridview
            this.reloadPage();
        });
    }

    reloadPage(): void {
        this.paginator.changePage(this.paginator.getPage());
    }

    applyFilters(): void {
        //truyền params lên url thông qua router
        this._router.navigate([
            "app/gwebsite/asset",
            {
                filterText: this.filterText
            }
        ]);

        if (this.paginator.getPage() !== 0) {
            this.paginator.changePage(0);
            return;
        }
    }

    /**
     * Tạo pipe thay vì tạo từng hàm truncate như thế này
     * @param text
     */
    truncateString(text): string {
        return abp.utils.truncateStringWithPostfix(text, 32, "...");
    }

    //Refresh grid khi thực hiện create or edit thành công
    refreshValueFromModal(): void {
        if (this.createOrEditModal.asset.id) {
            for (let i = 0; i < this.primengTableHelper.records.length; ++i) {
                if (this.primengTableHelper.records[i].id === this.createOrEditModal.asset.id) {
                    this.primengTableHelper.records[i] = this.createOrEditModal.asset;
                    return;
                }
            }
        } else {
            this.reloadPage();
        }
    }

    //hàm show view create MenuClient
    createAsset() {
        this.createOrEditModal.show();
    }
}
