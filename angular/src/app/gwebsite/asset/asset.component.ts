import {HttpClient, HttpHeaders} from '@angular/common/http'
import { AfterViewInit, Component, ElementRef, Injector, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Paginator } from 'primeng/components/paginator/paginator';
import { AppComponentBase } from '@shared/common/app-component-base';
import { WebApiServiceProxy, IFilter } from '@shared/service-proxies/webapi.service';
import { AssetDto } from './dto/asset.dto'
import {CreateAsset} from './create-asset.component'
import { Table } from 'primeng/components/table/table';
import { isNullOrUndefined } from 'util';
@Component({
  selector: 'app-asset',
  templateUrl: './asset.component.html',
  styleUrls: ['./asset.component.css']
})
export class AssetComponent extends AppComponentBase implements OnInit {
  @ViewChild('paginator') paginator: Paginator;
  @ViewChild('dataTable') dataTable: Table;
  @ViewChild('textsTable') textsTable: ElementRef;
  @ViewChild('createAsset') createAsset : CreateAsset;
  area: string;
  unitcode: string;
  areacode:string;
  transaction:string;
  assetcode:string;
  assetname: string;
  serinumber: string;
  originalprice: number;
  isInit  = false;
  asset: AssetDto = new AssetDto();
  assets : object;
  filteredAssets: object;
  searchTerm: string;
  searchTermAN: string;
  searchTermSR:string;
  get Area():string{
    return this.area;
  }
  set Area(val:string){
    this.area=val;
  }
  get AreaCode():string{
    return this.areacode;
  }
  set AreaCode(val:string){
    this.areacode=val;
  }
  get AssetName():string{
    return this.assetname;
  }
  set AssetName(val:string){
    this.assetname=val;
  }
  get SeriNumber():string{
    return this.serinumber;
  }
  set SeriNumber(val:string){
    this.serinumber=val;
  }
  get Transaction():string{
    return this.transaction;
  }
  set Transaction(val:string){
    this.transaction=val;
  }
  get AssetCode():string{
    return this.assetcode;
  }
  set AssetCode(val:string){
    this.assetcode=val;
  }
  get OriginalPrice():number{
    return this.originalprice;
  }
  set OriginalPrice(val:number){
    this.originalprice=val;
  }
  get SearchTerm(): string {
    return this.searchTerm;
  }
  set SearchTeam(val: string){
    this.searchTerm = val;
  }
  get SearchTeamAN(): string {
    return this.searchTermAN;
  }
  set SearchTeamAN(val:string){
    this.searchTermAN = val;
  }
  get SearchTeamSR(): string {
    return this.searchTermSR;
  }
  set SearchTeamSR(val:string){
    this.searchTermSR = val;
  }
  constructor(
    private http: HttpClient,
    injector: Injector,
    private _router: Router,
    private _activatedRoute: ActivatedRoute,
    private _apiService: WebApiServiceProxy,
    ) {
      super(injector);
     }

  ngOnInit() {
    if(!this.isInit)
    {
    this.getAssets().subscribe(data=>{
      this.assets = data;
    })
    this.isInit=true;
    }
    else{
      this.assets=this.filteredAssets;
    }
    console.log(this.isInit);
  }
  
  getAssets()
  {
    return this.http.get("http://localhost:5000/api/Asset/GetAssets");
  }
  get(event: Event)
  {
    let term1,term2,term3 : string;
    if(!isNullOrUndefined(this.searchTerm))
      term1="Area="+this.SearchTerm;
    else
      term1=null;
    if(!isNullOrUndefined(this.searchTermAN))
      term2 ="&AssetName="+this.searchTermAN;
    else
      term2=null;
    if(!isNullOrUndefined(this.searchTermSR))
      term3="&Serinumber="+this.searchTermSR;
    else{
        term3=null;
      }
      console.log(this.searchTerm+this.searchTermAN+this.searchTermSR);
    
      this.http.get("http://localhost:5000/api/Asset/GetAssetsByFilter?"+term1+term2+term3).subscribe(data=>{
      this.assets = data;
    });
    this.searchTerm=this.searchTerm;
    this.SearchTeamAN="";
    this.searchTermSR="";
    //this.reloadPage();
    
  }
  getAssetsByFilter(filtertext: string){
    this._apiService.get("api/Asset/GetAssetsByFilter",[
      {fieldName:"Area",value: filtertext }
    ]).subscribe(data=>{
      this.filteredAssets = data;
    })
  }
  reloadPage(): void {      
    this.paginator.changePage(this.paginator.getPage());
    console.log("reload");
  }
  check(){
    if(isNullOrUndefined(this.area)||isNullOrUndefined(this.unitcode)||isNullOrUndefined(this.areacode)||
    isNullOrUndefined(this.transaction)||isNullOrUndefined(this.assetcode)||isNullOrUndefined(this.assetname)||
    isNullOrUndefined(this.serinumber)||isNullOrUndefined(this.originalprice))
    {
      this.notify.info("Please Input Correctly!!!");
      return true;
    }
  }
  insertAsset(event: Event){
    if(this.check())
      return;
    this.asset.area=this.area;
    this.asset.unitcode=this.unitcode;
    this.asset.areacode=this.areacode;
    this.asset.transaction=this.transaction;
    this.asset.assetcode=this.assetcode;
    this.asset.assetname=this.assetname;
    this.asset.serialnumber=this.serinumber;
    this.asset.originalprice=this.originalprice;
    this.http.post("http://localhost:5000/api/Asset/CreateAsset",this.asset).subscribe(()=>{
        this.notify.info(this.l('SavedSuccessfully'));
    })
}
}
