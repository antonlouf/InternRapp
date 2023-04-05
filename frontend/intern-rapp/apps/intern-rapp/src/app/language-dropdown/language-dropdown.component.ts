import {  ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatOptionModule, MatOptionSelectionChange } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';
import { LanguageOption } from '../enums/languageDropdownOptions';
import { TranslateService,TranslateModule } from '@ngx-translate/core';

@Component({
  selector: 'intern-rapp-language-dropdown',
  standalone: true,
  imports: [CommonModule,MatFormFieldModule,MatOptionModule,MatSelectModule,TranslateModule],
  templateUrl: './language-dropdown.component.html',
  styleUrls: ['./language-dropdown.component.scss']
})
export class LanguageDropdownComponent implements OnInit{
  constructor(public translateService: TranslateService){ }
  public availableLanguages=Object(LanguageOption)
  
  ngOnInit(): void {
    const capitalizedLanguage=this.capitalize(this.translateService.getBrowserCultureLang()?.split("-")[0] as string)
    if(Object.keys(LanguageOption).includes(capitalizedLanguage))
    {
      this.translateService.currentLang=capitalizedLanguage
    }
    else
    {
      this.translateService.currentLang="Nl"
      
    }
    this.translateService.addLangs(Object.keys(LanguageOption))
    this.translateService.setDefaultLang(this.translateService.currentLang)

  }
  private  capitalize = (s:string) => s[0].toUpperCase() + s.slice(1)
  languageChanged(event: MatOptionSelectionChange){
    if(!event.isUserInput)return
    this.translateService.use(event.source.value)
    this.translateService.currentLang=event.source.value
  }
}
