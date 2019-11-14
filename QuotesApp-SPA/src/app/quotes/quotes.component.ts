import { Component, OnInit } from '@angular/core';
import { Quote } from '../models/Quote';
import { AlertifyService } from '../services/alertify.service';
// import { QuoteService } from '../services/quote.service';
import { UserService } from '../services/User.service';
import { User } from '../models/User';

@Component({
  selector: 'app-quotes',
  templateUrl: './quotes.component.html',
  styleUrls: ['./quotes.component.css']
})
export class QuotesComponent implements OnInit {
  users: User[];
  constructor(private userService: UserService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.getQuotes();
  }
  getQuotes() {
    this.userService.getUsers().subscribe((users: User[]) => {
      this.users = users;
    }, error => {
      this.alertify.error(error);
    });
  }
}
