import { ComboboxItemDto } from "@shared/service-proxies/service-proxies";

export class AssetDto {
    id: number;
    name: string;
    alias: string;
    categoryID: number;
    seri: string;
    originalPrice: number;
    dateCheckIn: Date;
    monthDepreciation: number;
    unitCalculation: string;
    isDeleted: boolean;
    //reateDepreciation: number;
    //totalCount: number;
    depreciationCategory: string;
}

export class GetAssetOutput {
    asset: AssetDto;
    assets: ComboboxItemDto[];
}