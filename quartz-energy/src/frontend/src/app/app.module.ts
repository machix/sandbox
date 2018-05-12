import { appRouting } from './app.routing';
import { VegaModule } from './vega/vega.module';
import { AppComponent } from './app.component';
import { NgModule } from '@angular/core';
import { FracScheduleModule } from './frac-schedule/frac-schedule.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    appRouting,
    VegaModule.forRoot(),
    FracScheduleModule.forRoot()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
