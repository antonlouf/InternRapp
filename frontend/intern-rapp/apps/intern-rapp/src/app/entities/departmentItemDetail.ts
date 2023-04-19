import { LanguageItem } from "./languageItem";
import { PrefaceTranslationCreateUnit } from "./prefaceTranslationCreateUnit";

export interface DepartmentItemDetail {
  id: number;
  name: string;
  managerEmails: string[];
  language: LanguageItem;
  preface: PrefaceTranslationCreateUnit[] | null;
}