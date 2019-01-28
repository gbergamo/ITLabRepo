import { Component, OnInit } from '@angular/core';
import { PersonConsumer } from '../consumers/person';
import { Person } from '../model/person';

@Component({
  selector: 'app-list-component',
  templateUrl: './list.component.html'
})
export class ListComponent implements OnInit {

  personList: Array<Person> = new Array<Person>();

  constructor(private consumer: PersonConsumer) { }

  ngOnInit() {
    this.getData();
  }

  private getData() {
    this.consumer.getPerson().subscribe(
      data => {
        this.personList = data;
      });
  }
}
