import { QueryBuilderModule } from './query-builder/query-builder.module';
import { AppComponent } from './app.component';
import { NgModule } from '@angular/core';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    QueryBuilderModule.forRoot()
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
