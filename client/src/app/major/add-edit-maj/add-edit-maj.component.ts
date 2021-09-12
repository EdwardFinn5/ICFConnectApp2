import { Component, Input, OnInit } from '@angular/core';
import { SharedService } from 'src/app/_services/shared.service';

@Component({
  selector: 'app-add-edit-maj',
  templateUrl: './add-edit-maj.component.html',
  styleUrls: ['./add-edit-maj.component.css'],
})
export class AddEditMajComponent implements OnInit {
  constructor(private service: SharedService) {}

  @Input() maj: any;
  MajorId: string;
  MajorName: string;

  ngOnInit(): void {
    this.MajorId = this.maj.MajorId;
    this.MajorName = this.maj.MajorName;
  }

  addMajor() {
    var val = {
      MajorId: this.MajorId,
      MajorName: this.MajorName,
    };

    this.service.addMajor(val).subscribe((res) => {
      alert('successfully added');
      console.log(res);
    });
  }

  updateMajor() {
    var val = {
      MajorId: this.MajorId,
      MajorName: this.MajorName,
    };
    console.log(val);
    console.log(val);
    this.service.updateMajor(val).subscribe((res) => {
      alert('updated successfully');
    });
  }
}
