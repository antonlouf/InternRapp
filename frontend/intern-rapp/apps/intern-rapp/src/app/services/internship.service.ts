import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { APIConfiguration } from '../configurations/APIConfiguration';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { InternshipItem } from '../entities/internshipItem';
import { catchError, retry } from 'rxjs';
import { CreateInternship } from '../entities/createInternship';
import { InternshipTranslationUpdateDto } from '../entities/internshipTranslationUpdateDto';
import { InternshipDetailItem } from '../entities/internshipDetailItem';

@Injectable({
  providedIn: 'root'
})
export class InternshipService {

  constructor(private http:HttpClient) { }
  public entityTobeUpdated:InternshipDetailItem|undefined
  private baseSuffixApi="/api/InternShip";
  public filterAndPaginateLanguages(filterPaginationRequest:PaginationFilterRequest){
    return this.http.get<ResourceItemPagingResponse<InternshipItem>>(APIConfiguration.baseString+`${this.baseSuffixApi}?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&Filter=${filterPaginationRequest.filterString}`).pipe(catchError((err,caught)=>caught))

  }
  public getInternshipById(id:number){
    return this.http.get<InternshipDetailItem>(APIConfiguration.baseString+`${this.baseSuffixApi}/${id}`)
  }
  public createInternship(internship: CreateInternship){
    

  
    return this.http.post(APIConfiguration.baseString+`${this.baseSuffixApi}`,    {
      "schoolYear": internship.schoolYear,
      "unitId": internship.unitId,
      "maxCountOfStudents": internship.maxCountOfStudents,
      "currentCountOfStudents": internship.currentCountOfStudents,
      "trainingType":Number(internship.trainingType),
      "locations": internship.locations,
      "versions": internship.versions
  },{
      headers:{
        "content-type":"application/json"
      }
    }).pipe(catchError((err,caught)=>caught),retry(2))

  }
}
