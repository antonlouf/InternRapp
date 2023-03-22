import { Inject, Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { LOCALE_ID } from '../injectionTokens/LOCALE_ID';

@Injectable()
export class AcceptHeaderInterceptor implements HttpInterceptor {

  constructor(@Inject(LOCALE_ID) private localId: string) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    return next.handle( request.clone({
      setHeaders:{
        'accept-language':this.localId
      }
    }));
  }
}
