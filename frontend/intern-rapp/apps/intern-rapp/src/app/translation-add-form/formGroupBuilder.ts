import { FormGroup, FormControl, Validators } from '@angular/forms';
import { InternshipTranslation } from '../entities/internshipTranslation';
import { InternshipTranslationUpdateDto } from '../entities/internshipTranslationUpdateDto';

export function buildFormGroupForTranslations(data:InternshipTranslationUpdateDto|undefined,languageId:number|undefined=undefined,languageName:string|undefined=undefined){
    return new FormGroup({
        titleContent:new FormControl(data?.titleContent??'',[Validators.required]),
        description:new FormControl(data?.description??'',[Validators.required]),
        knowledgeToDevelop:new FormControl(data?.knowledgeToDevelop??'',[Validators.required]),
        location:new FormControl(data?.location??'',[Validators.required]),
        comment:new FormControl(data?.comment??'',[Validators.required]),
        content:new FormControl(data?.content??'',[Validators.required]),
        languageId:new FormControl(data?.languageId??languageId,[Validators.required]),
        languageName:new FormControl(data?.languageName??languageName,[Validators.required])
    })

}