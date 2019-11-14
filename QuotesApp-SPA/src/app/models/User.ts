import { Quote } from './Quote';

export interface User {
  id: number;
  username: string;
  quotes?: Quote[];
}
