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

  MajorIdFilter: string = '';
  MajorNameFilter: string = '';
  MajorListWithoutFilter: any = [];

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
    console.log(major);
    console.log(major.MajorId);
    if (confirm('Are you sure??')) {
      this.service.deleteMajor(major.MajorId).subscribe((data) => {
        console.log(data);
        alert('Deleted successfully');
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
      this.MajorListWithoutFilter = data;
      console.log(data);
    });
  }

  FilterFn() {
    var MajorIdFilter = this.MajorIdFilter;
    var MajorNameFiler = this.MajorNameFilter;

    this.majorList = this.MajorListWithoutFilter.filter(function (el: any) {
      return (
        el.MajorId.toString()
          .toLowerCase()
          .includes(MajorIdFilter.toString().trim().toLowerCase()) &&
        el.MajorName.toString()
          .toLowerCase()
          .includes(MajorNameFiler.toString().trim().toLowerCase())
      );
    });
  }

  sortResult(prop, asc) {
    this.majorList = this.MajorListWithoutFilter.sort(function (a, b) {
      if (asc) {
        return a[prop] > b[prop] ? 1 : a[prop] < b[prop] ? -1 : 0;
      } else {
        return b[prop] > a[prop] ? 1 : b[prop] < a[prop] ? -1 : 0;
      }
    });
  }
}
