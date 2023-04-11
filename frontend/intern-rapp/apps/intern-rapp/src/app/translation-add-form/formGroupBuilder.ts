import { FormGroup, FormControl, Validators, FormArray } from '@angular/forms';
import { InternshipTranslation } from '../entities/internshipTranslation';
import { InternshipTranslationUpdateDto } from '../entities/internshipTranslationUpdateDto';
export function convertFormsArrayToObject(formArray: FormArray):InternshipTranslation[]{
    const tranformedVersions:InternshipTranslation[]=[]
    
    formArray.controls.forEach(x=>{
      tranformedVersions.push({
        comment:(x as FormGroup).controls['comment'].value,
      content:(x as FormGroup).controls['content'].value,
      description:(x as FormGroup).controls['description'].value,
      knowledgeToDevelop:(x as FormGroup).controls['knowledgeToDevelop'].value,
      languageId:(x as FormGroup).controls['languageId'].value,
      location:(x as FormGroup).controls['location'].value,
      neededKnowledge:(x as FormGroup).controls['neededKnowledge'].value,
      titleContent:(x as FormGroup).controls['titleContent'].value,
      
    })
    
    }
    
    )
    return tranformedVersions
}
export function buildFormGroupForTranslations(data:InternshipTranslationUpdateDto|undefined,languageId:number|undefined=undefined,languageName:string|undefined=undefined){
  
  return new FormGroup({
        titleContent:new FormControl(data?.titleContent??'',[Validators.required]),
        description:new FormControl(data?.description??'',[Validators.required]),
        knowledgeToDevelop:new FormControl(data?.knowledgeToDevelop??'',[Validators.required]),
        location:new FormControl(data?.location??'',[Validators.required]),
        comment:new FormControl(data?.comment??'',[Validators.required]),
        content:new FormControl(data?.content??'',[Validators.required]),
        neededKnowledge:new FormControl(data?.neededKnowledge??'',[Validators.required]),
        languageId:new FormControl(data?.language.id??languageId,[Validators.required]),
        languageName:new FormControl(data?.language.name??languageName,[Validators.required])
    })

}
