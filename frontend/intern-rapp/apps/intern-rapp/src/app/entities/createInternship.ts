import { InternshipTranslation } from "./internshipTranslation"

export interface CreateInternship{
    schoolYear: string
    unitId: number
    maxCountOfStudents: number
    currentCountOfStudents: number
    trainingType: number
    locationId: number
    versions: InternshipTranslation[]
}