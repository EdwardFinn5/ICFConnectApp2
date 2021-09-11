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
  majorId: string;
  majorName: string;

  ngOnInit(): void {
    this.majorId = this.maj.MajorId;
    this.majorName = this.maj.MajorName;
  }

  addMajor() {
    var val = {
      MajorId: this.majorId,
      MajorName: this.majorName,
    };

    this.service.addMajor(val).subscribe((result) => {
      alert(result.toString());
    });
  }

  UpdateMajor() {
    var val = {
      MajorId: this.majorId,
      MajorName: this.majorName,
    };

    this.service.updateMajor(val).subscribe((result) => {
      alert(result.toString());
    });
  }
}
