import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { Observable } from "rxjs";
import { SearchResult } from 'src/app/models/search-result';

@Injectable({
  providedIn: "root"
})
export class MusicClient {
  constructor(private http: HttpClient) {}

  search(query: string): Observable<SearchResult[]> {
    return this.http.get<SearchResult[]>(
      `${environment.apiBaseUri}/musicsearch?query=${query}`
    );
  }
}
