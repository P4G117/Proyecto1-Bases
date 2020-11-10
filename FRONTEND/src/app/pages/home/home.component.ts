import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent{
  i=0;
  img=["../../../assets/Images/image 8.png",
          '../../../assets/Images/image 9.png',
          '../../../assets/Images/image 10.png',
          '../../../assets/Images/image 11.png']

  constructor() { }
  left() {
    if (this.i > 0) {
      this.i = this.i - 1;
    }
  }

  right() {
    if (this.i < 4) {
      this.i = this.i + 1;
    }
  }

}
