import { QueryBuilderConfigService } from './services/common/concrete/query-builder-config.service';
import { IConfigServiceToken } from './../common/services/config/i-config-service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ModuleWithProviders } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

// main component
import { QueryBuilderComponent } from './query-builder.component';

// routing
import { queryBuilderRouting } from './query-builder.routing';

// bootstrap module
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MalihuScrollbarModule } from 'ngx-malihu-scrollbar';
import { ClipboardModule } from 'ngx-clipboard';

// pages
import { DashboardPageComponent } from './pages/dashboard-page/dashboard-page.component';
import { ResultPageComponent } from './pages/result-page/result-page.component';
import { ListManagerPageComponent } from './pages/list-manager-page/list-manager-page.component';
import { SavedQueriesPageComponent } from './pages/saved-queries-page/saved-queries-page.component';
import { AboutPageComponent } from './pages/about-page/about-page.component';

// reusable components
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { LeftSidebarComponent } from './components/left-sidebar/left-sidebar.component';
import { RightSidebarComponent } from './components/right-sidebar/right-sidebar.component';

import { QueryItemComponent } from './components/query-item/query-item.component';
import { StatementItemComponent } from './components/statement-item/statement-item.component';
import { TermItemComponent } from './components/term-item/term-item.component';
import { ResultTableComponent } from './components/result-table/result-table.component';
import { ModalWindowsComponent } from './components/modal-windows/modal-windows.component';

import { SharedModule } from './shared/shared.module';
import { DataListService } from './shared/data-list/data-list.service';

// Angular Material
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatPaginatorModule } from '@angular/material/paginator';

// Common features
import { AppCommonModule } from './../common/app-common.module';

@NgModule({
  declarations: [
    QueryBuilderComponent,
    DashboardPageComponent,
    ResultPageComponent,
    ListManagerPageComponent,
    SavedQueriesPageComponent,
    AboutPageComponent,

    HeaderComponent,
    FooterComponent,
    LeftSidebarComponent,
    RightSidebarComponent,
    QueryItemComponent,
    StatementItemComponent,
    TermItemComponent,
    ResultTableComponent,
    ModalWindowsComponent,
    QueryBuilderComponent,
  ],
  imports: [
            AppCommonModule.forRoot(),
            BrowserModule,
            FormsModule,
            HttpClientModule,
            NgbModule.forRoot(),
            MalihuScrollbarModule.forRoot(),
            ClipboardModule,
            SharedModule.forRoot(),
            queryBuilderRouting,
            BrowserAnimationsModule,
            MatPaginatorModule,
           ],
  exports: [
    QueryBuilderComponent
  ],
  bootstrap: [QueryBuilderComponent]
})
export class QueryBuilderModule {
    public static forRoot(): ModuleWithProviders {
        return {
        ngModule: QueryBuilderModule,
        providers: [
            DataListService,
            { provide: IConfigServiceToken, useClass: QueryBuilderConfigService }
          ]
        };
    }
}
