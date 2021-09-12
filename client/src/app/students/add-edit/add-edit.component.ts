import { Component, Input, OnInit } from '@angular/core';
import { SharedService } from 'src/app/_services/shared.service';

@Component({
  selector: 'app-add-edit',
  templateUrl: './add-edit.component.html',
  styleUrls: ['./add-edit.component.css'],
})
export class AddEditComponent implements OnInit {
  constructor(private service: SharedService) {}

  @Input() user: any;
  AppUserId: string;
  FirstName: string;
  UserType: string;
  Major: string;
  PhotoFileName: string;
  PhotoFilePath: string;

  majorsList: any = [];

  ngOnInit(): void {
    this.loadMajorList();
  }

  loadMajorList() {
    this.service.getAllMajorNames().subscribe((data: any) => {
      this.majorsList = data;

      this.AppUserId = this.user.AppUserId;
      this.FirstName = this.user.FirstName;
      this.UserType = this.user.UserType;
      this.Major = this.user.Major;
      this.PhotoFileName = this.user.PhotoFileName;
      this.PhotoFilePath = this.service.PhotoUrl + this.PhotoFileName;
    });
  }

  addUser() {
    var val = {
      AppUserId: this.AppUserId,
      FirstName: this.FirstName,
      UserType: this.UserType,
      Major: this.Major,
      PhotoFileName: this.PhotoFileName,
    };

    this.service.addUser(val).subscribe((res) => {
      alert('successfully added');
      console.log(res);
    });
  }

  updateUser() {
    var val = {
      AppUserId: this.AppUserId,
      FirstName: this.FirstName,
      UserType: this.UserType,
      Major: this.Major,
      PhotoFileName: this.PhotoFileName,
    };
    console.log(val);
    console.log(val);
    this.service.updateUser(val).subscribe((res) => {
      alert('updated successfully');
    });
  }

  uploadPhoto(event) {
    var file = event.target.files[0];
    const formData: FormData = new FormData();
    formData.append('uploadedFile', file, file.name);

    this.service.uploadPhoto(formData).subscribe((data: any) => {
      this.PhotoFileName = data.toString();
      this.PhotoFilePath = this.service.PhotoUrl + this.PhotoFileName;
    });
  }
}
