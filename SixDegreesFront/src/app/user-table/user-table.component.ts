import { Component } from '@angular/core';
import { UserService } from '../user.service';

@Component({
  selector: 'app-user-table',
  templateUrl: './user-table.component.html',
  styleUrls: ['./user-table.component.css']
})
export class UserTableComponent {
  usuarios: any[] = [];
  errorMessage: string = '';
  showTable: boolean = false;
  searchTerm: any;

  constructor(private userService: UserService) {}

  getUsers() {
      this.userService.getUsers().subscribe(
          response => {
              if (response.success) {
                  this.usuarios = response.data;
                  this.showTable = true;
              } else {
                  this.errorMessage = response.errorMessage;
              }
          },
          error => {
              this.errorMessage = 'Error al obtener los usuarios.';
          }
      );
  }

  buscarUsuarios() {
    this.getUsers();
  }
}
