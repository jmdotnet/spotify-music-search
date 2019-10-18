import { Component, OnInit } from "@angular/core";
import { MusicClient } from "src/app/api/clients/music.client";
import { AlertService } from "src/app/services/alert.service";

@Component({
  selector: "app-search",
  templateUrl: "./search.component.html",
  styleUrls: ["./search.component.scss"]
})
export class SearchComponent implements OnInit {
  public query = "";
  public results = [];

  constructor(
    private musicClient: MusicClient,
    private alertService: AlertService
  ) {}

  ngOnInit() {}

  public search(): void {
    if (this.query) {
      this.musicClient.search(this.query).subscribe(
        searchResult => {
          let grouped = searchResult.reduce((accumulator, searchResult) => {
            let group = searchResult.name[0];
            if (!accumulator[group])
              accumulator[group] = { group, items: [searchResult] };
            else accumulator[group].items.push(searchResult);

            return accumulator;
          }, {});

          this.results = Object.values(grouped);

          console.log(this.results);
        },
        error => {
          this.alertService.Error(
            ":( An error has occured while processing your search."
          );
        }
      );
    } else {
      this.alertService.Warning("Enter an Artist or Album");
    }
  }

  private alert(message: string): void {}
}
