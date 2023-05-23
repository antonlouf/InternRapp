import { HttpClient, HttpHeaders } from '@angular/common/http';
import { TranslateLoader } from '@ngx-translate/core';
import { Observable, tap } from 'rxjs';
import { APIConfiguration } from '../configurations/APIConfiguration';
export class customTranslate implements TranslateLoader{
private baseSuffixApi="api/Language";
 constructor(private http: HttpClient){}
    getTranslation(lang: string): Observable<unknown> {
         const httpOptions = {
           headers: new HttpHeaders({
             path: `${this.baseSuffixApi}/${lang}`,
             method: 'GET',
           }),
         };
        return this.http.get(`${APIConfiguration.baseString}`,httpOptions)
    }
 
 
}