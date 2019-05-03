import { ComboboxItemDto } from '@shared/service-proxies/service-proxies';

export class DepreciationModel {
    id: number;
    name: string;
    assetId: string;
    quantity: number;
    departmentId: string;
    calculationMethod: string;
    dateOfStartCalculateDepreciation: Date | null;
    expiryDate: Date | null;
    originalPrice: number;
    depreciationValue: number | null;
    monthlyDepreciationRate: number | null;
    annualDepreciationRate: number | null;
}

export class GetDepreciationOutput {
    depreciation: DepreciationModel;
    depreciations: ComboboxItemDto[];
}
