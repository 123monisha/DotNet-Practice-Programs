// app.component.html
<form (ngSubmit)="onSubmit()">
  <label>Name:</label>
  <input type="text" [(ngModel)]="user.name" name="name" required />

  <label>Email:</label>
  <input type="email" [(ngModel)]="user.email" name="email" required />

  <button type="submit">Submit</button>
</form>
