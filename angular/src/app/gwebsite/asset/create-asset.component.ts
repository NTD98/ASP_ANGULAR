import {HttpClient, HttpHeaders} from '@angular/common/http'
import { AfterViewInit, Component,EventEmitter, ElementRef, Injector, OnInit, ViewChild, Output } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Paginator } from 'primeng/components/paginator/paginator';
import { AppComponentBase } from '@shared/common/app-component-base';
import { WebApiServiceProxy, IFilter } from '@shared/service-proxies/webapi.service';
import { AssetDto } from './dto/asset.dto'
import { Table } from 'primeng/components/table/table';
import { isNullOrUndefined } from 'util';
import { ModalDirective } from 'ngx-bootstrap';
@Component({
    selector: 'create-asset',
    templateUrl: './asset.component.html',
    styleUrls: ['./asset.component.css'],
  })

  export class CreateAsset extends AppComponentBase
  {
    @ViewChild('createAsset') modal: ModalDirective;
      asset: AssetDto = new AssetDto();
    /**
     * @Output dùng để public event cho component khác xử lý
     */
    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();
    constructor(
        injector: Injector,
        private _apiService: WebApiServiceProxy,
        private http: HttpClient,
    ) {
        super(injector);
    }
    insertAsset(){
        this.http.post("http://localhost:5000/api/MenuClient/CreateMenuClient",this.asset,{
            headers: new HttpHeaders({
                'Content-Type': 'application/json'
            })
        }).subscribe(()=>{
            this.notify.info(this.l('SavedSuccessfully'));
                this.close();
                this.modalSave.emit(null);
        })
    }
    close(): void {
        this.modal.hide();
    }
    public show(): void {
        this.modal.show();
    }
  }