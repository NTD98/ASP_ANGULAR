import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { MenuClientComponent } from "@app/gwebsite/menu-client/menu-client.component";
import { AssetComponent } from "./asset/asset.component";
import { DepreciationComponent } from "@app/gwebsite/components/depreciation/depreciation.component";

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: "",
                children: [
                    {
                        path: "menu-client",
                        component: MenuClientComponent,
                        data: { permission: "Pages.Administration.MenuClient" }
                    },
                    {
                        path: "asset",
                        component: AssetComponent,
                        data: { permission: "Pages.Administration.Asset" }
                    },
                    {
                        path: "depreciation",
                        component: DepreciationComponent,
                        data: {
                            permission: "Pages.Administration.Depreciation"
                        }
                    }
                ]
            }
        ])
    ],
    exports: [RouterModule]
})
export class GWebsiteRoutingModule {}
