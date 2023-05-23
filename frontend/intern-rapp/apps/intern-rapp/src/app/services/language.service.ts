import { Injectable, OnInit } from '@angular/core';
import { LanguageItem } from '../entities/languageItem';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { CreateLanguage } from '../entities/createLanguage';
import { APIConfiguration } from '../configurations/APIConfiguration';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { catchError, retry } from 'rxjs';
import { LanguageWithMinimalData } from '../entities/languageWithMinimalData';

@Injectable({
  providedIn: 'root'
})
export class LanguageService{
  constructor(private http: HttpClient) {

   }
  
  private baseSuffixApi="/api/Language";

 
  filterAndPaginateLanguages(filterPaginationRequest: PaginationFilterRequest) {
     const httpOptions = {
       headers: new HttpHeaders({
         path: `${this.baseSuffixApi}?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&${filterPaginationRequest.filterString}`,
         method: 'GET',
       }),
     };
    return this.http.get<ResourceItemPagingResponse<LanguageItem>>(APIConfiguration.baseString,httpOptions)
      .pipe(catchError((err, caught) => caught), retry(2))
  }
  getById(id: number) {
         const httpOptions = {
           headers: new HttpHeaders({
             path: `${this.baseSuffixApi}/${id}`,
             method: 'GET',
           }),
         };
    return this.http
      .get<LanguageWithMinimalData>(APIConfiguration.baseString,httpOptions)
      .pipe(
        catchError((err, caught) => caught),
        retry(2)
      );
  }
  deleteLanguage(ids: number[] | undefined) {
      const httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          path: `${this.baseSuffixApi}`,
          method: 'DELETE',
        }),
        body: JSON.stringify(ids),
      };
    return this.http.delete<number>(APIConfiguration.baseString + `${this.baseSuffixApi}`,httpOptions).pipe(catchError((err, caught) => caught))
}
updateLanguage(itemToBeUpdated: LanguageItem|undefined){
   const httpOptions = {
     headers: new HttpHeaders({
       path: `${this.baseSuffixApi}`,
       method: 'PATCH',
     }),
   };
  return this.http.patch(APIConfiguration.baseString, {
      "id": itemToBeUpdated?.id,
    "name": itemToBeUpdated?.name,
      "code":itemToBeUpdated?.code
  },httpOptions).pipe(catchError((err,caught)=>caught))

}

addLanguage(itemToBeAdded: CreateLanguage){
   const httpOptions = {
     headers: new HttpHeaders({
       path: `${this.baseSuffixApi}`,
       method: 'CREATE',
     }),
   };
  return this.http.post(APIConfiguration.baseString,itemToBeAdded,httpOptions).pipe(catchError((err,caught)=>caught))

}

}
