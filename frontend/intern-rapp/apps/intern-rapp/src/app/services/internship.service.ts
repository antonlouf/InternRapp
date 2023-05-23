import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { APIConfiguration } from '../configurations/APIConfiguration';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { InternshipItem } from '../entities/internshipItem';
import { catchError, retry } from 'rxjs';
import { CreateInternship } from '../entities/createInternship';
import { InternshipTranslationUpdateDto } from '../entities/internshipTranslationUpdateDto';
import { InternshipDetailItem } from '../entities/internshipDetailItem';
import { InternshipUpdateDto } from '../entities/internshipUpdateDto';
import { ExportInternshipOptions } from '../entities/exportInternshipOptions';

@Injectable({
  providedIn: 'root',
})
export class InternshipService {
  constructor(private http: HttpClient) {}
  public entityTobeUpdated: InternshipDetailItem | undefined;
  private baseSuffixApi = '/api/InternShip';
  public filterAndPaginateLanguages(
    filterPaginationRequest: PaginationFilterRequest
  ) {
     const httpOptions = {
       headers: new HttpHeaders({
         path: `${this.baseSuffixApi}?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&${filterPaginationRequest.filterString}`,
         method: 'GET',
       }),
     };
    return this.http
      .get<ResourceItemPagingResponse<InternshipItem>>(
        APIConfiguration.baseString,
        httpOptions
      )
      .pipe(catchError((err, caught) => caught));
  }
  public getInternshipById(id: number) {
    const httpOptions = {
      headers: new HttpHeaders({
        path: `${this.baseSuffixApi}/${id}`,
        method: 'GET',
      }),
    };
    return this.http.get<InternshipDetailItem>(
      APIConfiguration.baseString,httpOptions
    );
  }
  public createInternship(internship: CreateInternship) {
    const httpOptions = {
      headers: new HttpHeaders({
        path: `${this.baseSuffixApi}`,
        'content-type': 'application/json',
        method: 'POST',
      }),
    };
    return this.http
      .post(
        APIConfiguration.baseString ,
        {
          schoolYear: internship.schoolYear,
          unitId: internship.unitId,
          maxCountOfStudents: internship.maxCountOfStudents,
          currentCountOfStudents: internship.currentCountOfStudents,
          trainingType: Number(internship.trainingType),
          locations: internship.locations,
          versions: internship.versions,
        },
       httpOptions
      )
      .pipe(
        catchError((err, caught) => caught),
        retry(2)
      );
  }
  public copyToNextYear(ids: number[]) {
       const httpOptions = {
         headers: new HttpHeaders({
           path: `${this.baseSuffixApi}/copyToNextYear`,
           'content-type': 'application/json',
           method: 'POST',
         }),
       };
    return this.http
      .post(
        APIConfiguration.baseString ,
        ids,
       httpOptions
      )
      .pipe(
        catchError((err, caught) => caught),
        retry(2)
      );
  }
  public updateInternship(internship: InternshipUpdateDto) {
     const httpOptions = {
       headers: new HttpHeaders({
         path: `${this.baseSuffixApi}`,
         method: 'PUT',
         'content-type': 'application/json',
       }),
     };
    return this.http
      .put(
        APIConfiguration.baseString ,
        {
          schoolYear: internship.schoolYear,
          internshipId: internship.internShipId,
          unitId: internship.unitId,
          maxCountOfStudents: internship.maxCountOfStudents,
          currentCountOfStudents: internship.currentCountOfStudents,
          trainingType: Number(internship.trainingType),
          locations: internship.locations,
          versions: internship.versions,
        },
       httpOptions
      )
      .pipe(
        catchError((err, caught) => caught),
        retry(2)
      );
  }
  deleteInternship(ids: number[]) {
        const httpOptions = {
          headers: new HttpHeaders({
            'Content-Type': 'application/json',
            path: `${this.baseSuffixApi}`,
            method: 'DELETE',
          }),
          body: JSON.stringify(ids),
        };
    return this.http.delete(
      APIConfiguration.baseString ,httpOptions
    );
  }
  public exportInternships(filterCriteria: ExportInternshipOptions) {
    let queryString = ""
    for (let unit of filterCriteria.unitIds) {
      queryString += `unitIds=${unit}`
      if (filterCriteria.unitIds.indexOf(unit) < filterCriteria.unitIds.length - 1) {
        queryString+="&"
      }
    }
    queryString+=`&schoolYear=${filterCriteria.schoolYear}&languageId=${filterCriteria.languageId}`
     const httpOptions = {
       headers: new HttpHeaders({
         path: `${this.baseSuffixApi}/export?${queryString}`,
         method: 'GET',
       }),
     }; 
    return this.http.get(
        APIConfiguration.baseString,httpOptions )
  }
  
}
