import { Image } from "./image";

export interface SearchResult {
  name: string;
  images: Image[];
  type: number;
}
