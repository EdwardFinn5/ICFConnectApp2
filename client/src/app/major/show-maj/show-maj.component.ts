import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/_services/shared.service';

@Component({
  selector: 'app-show-maj',
  templateUrl: './show-maj.component.html',
  styleUrls: ['./show-maj.component.css'],
})
export class ShowMajComponent implements OnInit {
  constructor(private service: SharedService) {}

  majorList: any[];
  modalTitle: string;
  activateAddEditMajComp: boolean = false;
  maj: any;

  ngOnInit(): void {
    this.refreshMajorList();
  }

  addClick() {
    this.maj = {
      MajorId: 0,
      MajorName: '',
    };
    this.modalTitle = 'Add Major';
    this.activateAddEditMajComp = true;
  }
  editClick(major: any) {
    this.maj = major;
    this.modalTitle = 'Edit Major';
    this.activateAddEditMajComp = true;
  }

  deleteClick(major: any) {
    if (confirm('Are you sure??')) {
      this.service.deleteMajor(major.MajorId).subscribe((data) => {
        alert(data.toString());
        this.refreshMajorList();
      });
    }
  }

  closeClick() {
    this.activateAddEditMajComp = false;
    this.refreshMajorList();
  }

  refreshMajorList() {
    this.service.getMajorList().subscribe((data) => {
      this.majorList = data;
      console.log(data);
    });
  }
}
