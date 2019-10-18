import { Component, OnInit } from "@angular/core";
import { MatSnackBar } from "@angular/material/snack-bar";
import { AlertService } from "src/app/services/alert.service";
import { Alert } from 'src/app/models/alert';

@Component({
  selector: "app-alert",
  templateUrl: "./alert.component.html",
  styleUrls: ["./alert.component.scss"]
})
export class AlertComponent implements OnInit {
  public alert = {} as Alert;

  constructor(
    private alertService: AlertService,
    private snackbar: MatSnackBar
  ) {}

  ngOnInit() {
    this.alertService.activeAlert$.subscribe(a => {
      if (a) {
        this.alert = a;

        this.snackbar.open(a.message, null, {
          duration: 5 * 1000,
          verticalPosition: "top"
        });
      }
    });
  }
}
