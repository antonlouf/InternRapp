import { User } from "./user";

export interface Department{
    Id : number,
    Name :string,
    managers: User[]
}