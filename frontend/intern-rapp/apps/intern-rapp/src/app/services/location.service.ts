import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError } from 'rxjs';
import { APIConfiguration } from '../configurations/APIConfiguration';
import { PaginationFilterRequest } from '../entities/paginationFilterRequest';
import { ResourceItemPagingResponse } from '../entities/resourceItemPagingResponse';
import { LocationItem, } from '../entities/locationItem';
import { CreateLocation } from '../entities/createLocation';

@Injectable({
  providedIn: 'root'
})
export class LocationService {

  constructor(private http: HttpClient) {
   }

   private baseSuffixApi="/api/Location";

   filterAndPaginateLocations$(filterPaginationRequest: PaginationFilterRequest){
     const httpOptions = {
       headers: new HttpHeaders({
         path: `${this.baseSuffixApi}?PageIndex=${filterPaginationRequest.pageIndex}&PageSize=${filterPaginationRequest.pageSize}&${filterPaginationRequest.filterString}`,
         method: 'GET',
       }),
     };
     return this.http
       .get<ResourceItemPagingResponse<LocationItem>>
       (APIConfiguration.baseString, httpOptions)
    .pipe(catchError((err,caught)=>caught))
  }

  addLocation$(itemToBeAdded: CreateLocation) {
      const httpOptions = {
        headers: new HttpHeaders({
          path: `${this.baseSuffixApi}`,
          method: 'POST',
        }),
      };
    return this.http.post(APIConfiguration.baseString+
      `${this.baseSuffixApi}`,{
        "city": itemToBeAdded?.city,
        "streetname": itemToBeAdded?.streetname,
        "housenumber": itemToBeAdded?.housenumber,
        "zipcode": itemToBeAdded?.zipcode,
    },httpOptions)
    .pipe(catchError((err,caught)=>caught))
  }

  updateLocation$(itemToBeUpdated: LocationItem|undefined){
       const httpOptions = {
         headers: new HttpHeaders({
           path: `${this.baseSuffixApi}`,
           method: 'PATCH',
         }),
       };
    return this.http.patch(APIConfiguration.baseString,{
        "id": itemToBeUpdated?.id,
        "city": itemToBeUpdated?.city,
        "streetname": itemToBeUpdated?.streetname,
        "housenumber": itemToBeUpdated?.housenumber,
        "zipcode": itemToBeUpdated?.zipcode,
    },httpOptions).pipe(catchError((err,caught)=>caught))
  
  }

  deleteLocation$(ids: number[] | undefined) {
      const httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          path: `${this.baseSuffixApi}`,
          method: 'DELETE',
        }),
        body: JSON.stringify(ids),
      };
    return this.http.delete<number>(APIConfiguration.baseString,httpOptions)
    .pipe(catchError((err,caught)=>caught))
    }

}
