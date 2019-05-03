import { AfterViewInit, Component, ElementRef, Injector, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/common/app-component-base';
import * as _ from 'lodash';
import { LazyLoadEvent } from 'primeng/components/common/lazyloadevent';
import { Paginator } from 'primeng/components/paginator/paginator';
import { Table } from 'primeng/components/table/table';
import { CreateOrEditDepreciationComponent } from '../create-or-edit-depreciation/create-or-edit-depreciation.component';
import { WebApiServiceProxy, IFilter } from '@shared/service-proxies/webapi.service';

@Component({
  selector: 'app-depreciation',
  templateUrl: './depreciation.component.html',
  styleUrls: ['./depreciation.component.css'],
  animations: [appModuleAnimation()]
})
export class DepreciationComponent extends AppComponentBase implements AfterViewInit, OnInit {
  @ViewChild('textsTable') textsTable: ElementRef;
  @ViewChild('createOrEditModal') createOrEditModal: CreateOrEditDepreciationComponent;
  @ViewChild('dataTable') dataTable: Table;
  @ViewChild('paginator') paginator: Paginator;

  filterText: string;

  constructor(
    injector: Injector,
    private _router: Router,
    private _activatedRoute: ActivatedRoute,
    private _apiService: WebApiServiceProxy
  ) {
      super(injector);
  }

  ngOnInit(): void {
  }

  ngAfterViewInit(): void {
    setTimeout(() => {
        this.init();
    });
  }

  getDepreciations(event?: LazyLoadEvent) {
    if (!this.paginator || !this.dataTable) {
        return;
    }

    this.primengTableHelper.showLoadingIndicator();

    this._apiService.get('api/Depreciation/GetDepreciationsByFilter',
        [{ fieldName: 'Name', value: this.filterText }],
        this.primengTableHelper.getSorting(this.dataTable),
        this.primengTableHelper.getMaxResultCount(this.paginator, event),
        this.primengTableHelper.getSkipCount(this.paginator, event),
    ).subscribe(result => {
        this.primengTableHelper.totalRecordsCount = result.totalCount;
        this.primengTableHelper.records = result.items;
        this.primengTableHelper.hideLoadingIndicator();
    });
  }

  init(): void {
      this._activatedRoute.params.subscribe((params: Params) => {
          this.filterText = params['filterText'] || '';
          this.reloadPage();
      });
  }

  reloadPage(): void {
      this.paginator.changePage(this.paginator.getPage());
  }

  applyFilters(): void {
      this._router.navigate(['app/gwebsite/depreciation', {
          filterText: this.filterText
      }]);

      if (this.paginator.getPage() !== 0) {
          this.paginator.changePage(0);
          return;
      }
  }

  truncateString(text): string {
      return abp.utils.truncateStringWithPostfix(text, 32, '...');
  }

  refreshValueFromModal(): void {
      if (this.createOrEditModal.depreciation.id) {
          for (let i = 0; i < this.primengTableHelper.records.length; i++) {
              if (this.primengTableHelper.records[i].id === this.createOrEditModal.depreciation.id) {
                  this.primengTableHelper.records[i] = this.createOrEditModal.depreciation;
                  return;
              }
          }
      } else { this.reloadPage(); }
  }

  createDepreciation() {
      this.createOrEditModal.show();
  }
}
