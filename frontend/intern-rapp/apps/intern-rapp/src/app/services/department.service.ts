import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { APIConfiguration } from '../configurations/APIConfiguration';
import { catchError, Observable, of, retry, shareReplay, take } from 'rxjs';
import {  CreateDepartment } from '../entities/CreateDepartment';
import { PaginationRequest } from '../entities/paginationRequest';
import { DepartmentItem } from '../entities/departmentItem';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { DepartementItemWithMinimalData } from '../entities/depItemWithMinimalData';
import { DepartmentItemDetail } from '../entities/departmentItemDetail';
import { DepartmentUpdate } from '../entities/departmentUpdate';

@Injectable({
  providedIn: 'root',
})
export class DepartmentService {
  constructor(private http: HttpClient) {}
  private baseSuffixApi = '/api/Unit';
  getAllSupervisorNamesContaining(
    name: string | undefined
  ): Observable<string[]> {
          const httpOptions = {
            headers: new HttpHeaders({
              path:  `/api/ApplicationUser/?filterValue=${name}`,
              method: 'GET',
            }),
          };
    return this.http
      .get<string[]>(
        APIConfiguration.baseString ,httpOptions
         
      )
      .pipe(catchError((err, caught) => caught));
  }
  postDepartment(department: CreateDepartment) {
        const httpOptions = {
          headers: new HttpHeaders({
            path: `${this.baseSuffixApi}`,
            method: 'POST',
          }),
        };
    return this.http
      .post(APIConfiguration.baseString, department,httpOptions)
      .pipe(catchError((err, caught) => caught));
  }
  filterAndPaginateDepartments(
    filterPaginationRequest: PaginationFilterRequest
  ) {
      const httpOptions = {
        headers: new HttpHeaders({
          path:  `${this.baseSuffixApi}/?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&${filterPaginationRequest.filterString}`,
          method: 'GET',
        }),
      };
    return this.http
      .get<ResourceItemPagingResponse<DepartmentItem>>(
        APIConfiguration.baseString,httpOptions )
      .pipe(catchError((err, caught) => caught));
  }
  filterAndPaginateDepartmentsWithMinimalData(
    filterPaginationRequest: PaginationFilterRequest
  ) {
     const httpOptions = {
       headers: new HttpHeaders({
         path: `${this.baseSuffixApi}/getAllWithminimaldata?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&Filter=${filterPaginationRequest.filterString}`,
         method: 'GET',
       }),
     };
    return this.http
      .get<ResourceItemPagingResponse<DepartementItemWithMinimalData>>(
        APIConfiguration.baseString,httpOptions)
      .pipe(catchError((err, caught) => caught));
  }
  deleteDepartment(ids: number[] | undefined) {
      const httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          'path': `${this.baseSuffixApi}`,
          'method':"DELETE"
        }),
        body: JSON.stringify(ids),
      };
    return this.http
      .delete<number>(
        APIConfiguration.baseString,httpOptions
      )
      .pipe(catchError((err, caught) => caught));
  }
  updateDepartment(itemToBeUpdated: DepartmentUpdate | undefined) {
     const httpOptions = {
       headers: new HttpHeaders({
         path: `${this.baseSuffixApi}`,
         method: 'PATCH',
       }),
     };
    return this.http
      .patch(APIConfiguration.baseString, {
        id: itemToBeUpdated?.id,
        name: itemToBeUpdated?.name,
        managerEmails: itemToBeUpdated?.managerEmails,
        prefaceTranslations: itemToBeUpdated?.prefaceTranslations,
      },httpOptions)
      .pipe(
        catchError((error) => {
          throw error
          return of(null);
        }),
        // retry once
        retry(1),
        // only take the first value emitted (either successful or null)
        take(1)
      );
  }

  addDepartment(itemToBeAdded: CreateDepartment) {
    const body = {
      name: itemToBeAdded.name,
      superVisorEmails: itemToBeAdded.superVisorEmails,
      prefaceTranslations: itemToBeAdded.prefaces,
    };
    const httpOptions = {
         headers: new HttpHeaders({
           path: `${this.baseSuffixApi}`,
           method: 'POST',
         }),
       };
    return this.http
      .post(APIConfiguration.baseString , body,httpOptions)
      .pipe(
       
            catchError((error) => {
              console.error(error);
              return of(null);
            }),
          // retry once
          retry(1),
          // only take the first value emitted (either successful or null)
          take(1)
        )
      
  }
  public getById(id: number) {
       const httpOptions = {
         headers: new HttpHeaders({
           path: `${this.baseSuffixApi}/${id}`,
           method: 'GET',
         }),
       };
    return this.http
      .get<DepartmentItemDetail>(
        APIConfiguration.baseString 
      ,httpOptions)
      .pipe(
        catchError((error) => {
          return of(null);
        }),
        // retry once
        retry(1),
        // only take the first value emitted (either successful or null)
        take(1)
      );
  }
}

