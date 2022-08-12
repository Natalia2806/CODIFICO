import { Component, OnInit } from '@angular/core';
import { UserService } from './core/services/user.service';
import { UserI } from './core/models/user.interface';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'GitHubUser';
  userName: string = "";
  vacio: boolean = true;

  user: UserI = {
    id: 0,
    login: '',
    avatar_url: '',
    created_at: '',
    name: '',
    location: '',
    twitter_username: '',
    blog: '',
    public_repos: 0,
    followers: 0,
    following: 0
  };



  constructor(private _userService: UserService) { }

  ngOnInit() {

  }

  getUser() {
    if (this.userName != "") {
      this._userService.getUser(this.userName).subscribe(data => {
        let date = new Date(data.created_at);
        data.created_at = date.toDateString();
        this.user = data;
        if (this.user !== null && this.user !== undefined) {
          this.vacio = false;
        }
      });
    } else {
      this.vacio = true;
    }
  }
}
