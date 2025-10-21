import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent {
  newStudent: string = '';
  students: string[] = ['Monisha', 'Rahul', 'Sneha'];

  addStudent() {
    if (this.newStudent.trim() !== '') {
      this.students.push(this.newStudent);
      this.newStudent = ''; // clear input box
    }
  }
}
