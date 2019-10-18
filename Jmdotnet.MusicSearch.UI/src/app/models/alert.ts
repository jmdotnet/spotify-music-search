import { AlertLevel } from '../enums/alert-level';

export interface Alert {
    message:string;
    alertLevel: AlertLevel;
}