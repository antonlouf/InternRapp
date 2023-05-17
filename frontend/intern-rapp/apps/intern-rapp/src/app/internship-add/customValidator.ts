import { AbstractControl, ValidatorFn } from "@angular/forms";

export function islessThanOrEqualToMaxStudents(maxAllowedStudents:number): ValidatorFn {
  return (control: AbstractControl): { [key: string]: any } | null => {
      const value = control.value;
    if (value <= maxAllowedStudents) {
      return null;
    } else {
      return {
        customValidatorlessThanOrEqualToMaxStudents: {
          greaterThanMaxStudentsErrorMessage:
            'greaterThanMaxStudentsErrorMessage',
        },
      };
    }
  };
}
export function isLessThanOrEqualToParam(maxAllowedNumber: number): ValidatorFn{
    return (control: AbstractControl): { [key: string]: any } | null => {
        const value = control.value;
      if (  value <= maxAllowedNumber&&value>=0) {
        return null;
      } else {
        return {
          customLessThanOrEqualToParam: {
            greaterThanMaxAllowedError: 'GreaterThanParamLimitError',
          },
        };
      }
    };
}

