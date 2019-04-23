import { ComboboxItemDto } from '@shared/service-proxies/service-proxies';

export class AssetDto{
    id: number;
    area: string;
    unitcode: string;
    areacode: string;
    transaction: string;
    assetcode: string;
    assetname: string;
    serinumber: string;
    originalprice: number;
    parentId: number | null;
}

export class GetAssetOutput{
    asset: AssetDto;
    assets: ComboboxItemDto[];
}