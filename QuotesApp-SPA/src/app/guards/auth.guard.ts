import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthService } from '../services/auth.service';
import { AlertifyService } from '../services/alertify.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor( private authService: AuthService, private router: Router,
               private alertify: AlertifyService ) {}
  canActivate(): boolean {
    if (this.authService.loggedIn()) {
      return true;
    }
    // if not logged in
    this.alertify.error('Cannot access this page!');
    this.router.navigate(['/home']);
    return false;
  }
}
