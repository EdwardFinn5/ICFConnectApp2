import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/_services/shared.service';

@Component({
  selector: 'app-show-del',
  templateUrl: './show-del.component.html',
  styleUrls: ['./show-del.component.css'],
})
export class ShowDelComponent implements OnInit {
  constructor(private service: SharedService) {}

  userList: any[];
  modalTitle: string;
  activateAddEditUserComp: boolean = false;
  user: any;

  ngOnInit(): void {
    this.refreshUserList();
  }

  addClick() {
    this.user = {
      AppUserId: 0,
      FirstName: '',
      UserType: '',
      Major: '',
      PhotoFileName: 'anonymous.jpg',
    };
    this.modalTitle = 'Add User';
    this.activateAddEditUserComp = true;
  }
  editClick(user: any) {
    this.user = user;
    this.modalTitle = 'Edit User';
    this.activateAddEditUserComp = true;
  }

  deleteClick(user: any) {
    console.log(user);
    console.log(user.AppUserId);
    if (confirm('Are you sure??')) {
      this.service.deleteUser(user.AppUserId).subscribe((data) => {
        console.log(data);
        alert('Deleted successfully');
        this.refreshUserList();
      });
    }
  }

  closeClick() {
    this.activateAddEditUserComp = false;
    this.refreshUserList();
  }

  refreshUserList() {
    this.service.getUserList().subscribe((data) => {
      this.userList = data;
      console.log(data);
    });
  }
}
