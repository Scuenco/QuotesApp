import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { AlertifyService } from '../services/alertify.service';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { User } from '../models/User';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  user: User;
  registerForm: FormGroup;

  constructor(private authService: AuthService,
              private alertify: AlertifyService, private fb: FormBuilder,
              private router: Router ) { }

  ngOnInit() {
    this.createRegisterForm();
  }
  // using FormBuilder
  createRegisterForm() {
    this.registerForm = this.fb.group({
      username: ['', Validators.required],
      password: ['', [Validators.required, Validators.minLength(4)]],
      confirmPassword: ['', Validators.required]
    }, {validator: this.passwordMatchValidator});
  }
  // custom validator for password
  passwordMatchValidator(fg: FormGroup) {
    return (fg.get('password').value === fg.get('confirmPassword').value)
    ? null : { mismatch: true};
  }

  register() {
    if (this.registerForm.valid) {
      // Clones the value of this registerForm into this empty object
      this.user = Object.assign({}, this.registerForm.value);

      this.authService.register(this.user).subscribe( () => {
        this.alertify.success('Registration sucessfull');
      }, error => {this.alertify.error(error);
      }, () => {
        this.authService.login(this.user).subscribe(() => {
          this.router.navigate(['/quotes']);
        });
      });
    }
  }
  cancel() {
    this.cancelRegister.emit(false);
    console.log('cancelled');
  }
}
