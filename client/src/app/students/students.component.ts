import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css'],
})
export class StudentsComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}
  students = [
    {
      id: 1,
      name: 'Learn Angular',
      description:
        'Lorem Ipsum is simply dummy text of the printing and typesetting industry',
      image: '../../assets/angular.jpg',
    },
    {
      id: 2,
      name: 'Learn Typescript',
      description:
        'Lorem Ipsum is simply dummy text of the printing and typesetting industry',
      image: '../../assets/typescript.jpg',
    },
    {
      id: 3,
      name: 'Learn Nodejs',
      description:
        'Lorem Ipsum is simply dummy text of the printing and typesetting industry',
      image: '../../assets/nodejs.jpg',
    },
    {
      id: 4,
      name: 'Learn Reactjs',
      description:
        'Lorem Ipsum is simply dummy text of the printing and typesetting industry',
      image: '../../assets/reactjs.jpg',
    },
  ];
}
