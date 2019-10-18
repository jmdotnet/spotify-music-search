import { Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";
import { Alert } from "../models/alert";
import { AlertLevel } from "../enums/alert-level";

@Injectable({
  providedIn: "root"
})
export class AlertService {
  private alertSource = new BehaviorSubject<Alert>(undefined);
  public activeAlert$ = this.alertSource.asObservable();

  constructor() {}

  public Error(message: string): void {
    this.alertSource.next({
      message: message,
      alertLevel: AlertLevel.Error
    } as Alert);
  }

  public Warning(message: string): void {
    this.alertSource.next({
      message: message,
      alertLevel: AlertLevel.Error
    } as Alert);
  }

  public Success(message: string): void {
    this.alertSource.next({
      message: message,
      alertLevel: AlertLevel.Error
    } as Alert);
  }
}
