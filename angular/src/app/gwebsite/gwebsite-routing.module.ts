import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { MenuClientComponent } from '@app/gwebsite/menu-client/menu-client.component';
import { TestModuleComponent } from './test-module/test.component';
import { AssetComponent } from './asset/asset.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                children: [
                    {
                        path: 'menu-client', component: MenuClientComponent,
                        data: { permission: 'Pages.Administration.MenuClient' }
                    },
                    {
                        path: 'test-module', component: TestModuleComponent,
                        data:{ permission: 'Pages.Administration.TestModel' }
                    },
                    {
                        path:'asset', component: AssetComponent,
                        data:{permission: 'Pages.Administration.Asset'}
                    }
                ]
            }
        ])
    ],
    exports: [
        RouterModule
    ]
})
export class GWebsiteRoutingModule { }
