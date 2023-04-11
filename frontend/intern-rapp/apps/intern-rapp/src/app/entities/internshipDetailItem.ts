import { TrainingType } from "../enums/trainingType";
import { DepartementItemWithMinimalData } from "./depItemWithMinimalData";
import { InternshipTranslationUpdateDto } from "./internshipTranslationUpdateDto";
import { LocationItem } from "./locationItem";

export interface InternshipDetailItem{
    schoolYear:string,
    internshipId:number,
    unit:DepartementItemWithMinimalData,
    maxCountOfStudents:number,
    currentCountOfStudents:number,
    trainingType: TrainingType,
    locations:LocationItem[],
    versions:InternshipTranslationUpdateDto[]

}