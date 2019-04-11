import { ComboboxItemDto } from '@shared/service-proxies/service-proxies';

export class AssetDto{
    area: string;
    unitcode: string;
    areacode: string;
    transaction: string;
    assetcode: string;
    assetname: string;
    serialnumber: string;
    originalprice: number;
}

export class GetAssetOutput{
    asset: AssetDto;
    assets: ComboboxItemDto[];
}