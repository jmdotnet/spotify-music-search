import { TestBed } from "@angular/core/testing";

import { MusicClient } from "./music.client";

describe("MusicClient", () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it("should be created", () => {
    const service: MusicClient = TestBed.get(MusicClient);
    expect(service).toBeTruthy();
  });
});
