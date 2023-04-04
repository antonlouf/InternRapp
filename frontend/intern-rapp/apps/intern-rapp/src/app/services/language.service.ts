import { Injectable, OnInit } from '@angular/core';
import { LanguageItem } from '../entities/languageItem';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { CreateLanguage } from '../entities/createLanguage';
import { APIConfiguration } from '../configurations/APIConfiguration';
import { HttpClient } from '@angular/common/http';
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

 


  filterAndPaginateLanguages(filterPaginationRequest: PaginationFilterRequest){
    return this.http.get<ResourceItemPagingResponse<LanguageItem>>(APIConfiguration.baseString+`${this.baseSuffixApi}?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&Filter=${filterPaginationRequest.filterString}`).pipe(catchError((err,caught)=>caught),retry(2))
  }
  getById(id:number){
    return this.http.get<LanguageWithMinimalData>(APIConfiguration.baseString+`${this.baseSuffixApi}/${id}`).pipe(catchError((err,caught)=>caught),retry(2))
  }
  deleteLanguage(id: number|undefined){
return this.http.delete<number>(APIConfiguration.baseString+`${this.baseSuffixApi}?id=${id}`).pipe(catchError((err,caught)=>caught))
}
updateLanguage(itemToBeUpdated: LanguageItem|undefined){
  return this.http.patch(APIConfiguration.baseString+`${this.baseSuffixApi}`,{
      "id": itemToBeUpdated?.id,
      "name": itemToBeUpdated?.name,
  }).pipe(catchError((err,caught)=>caught))

}

addLanguage(itemToBeAdded: CreateLanguage){

  return this.http.post(APIConfiguration.baseString+`${this.baseSuffixApi}?languagenName=${itemToBeAdded.name}`,null).pipe(catchError((err,caught)=>caught))

}

}
