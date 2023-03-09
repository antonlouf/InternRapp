import { Observable } from "rxjs";
import { FilterType } from "../enums/filterType";

export interface Filter{
type: FilterType,
name: string,
label: string,
observable: Observable<Record<string,string>>|undefined
}