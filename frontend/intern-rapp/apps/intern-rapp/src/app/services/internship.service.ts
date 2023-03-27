import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { APIConfiguration } from '../configurations/APIConfiguration';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { InternshipItem } from '../entities/internshipItem';
import { catchError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InternshipService {

  constructor(private http:HttpClient) { }
  private baseSuffixApi="/api/InternShip";
  filterAndPaginateLanguages(filterPaginationRequest:PaginationFilterRequest){
    return this.http.get<ResourceItemPagingResponse<InternshipItem>>(APIConfiguration.baseString+`${this.baseSuffixApi}?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&Filter=${filterPaginationRequest.filterString}`).pipe(catchError((err,caught)=>caught))

  }
}
