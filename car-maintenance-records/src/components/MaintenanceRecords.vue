<template>
  <table class="table table-striped">
      <thead class="table-dark">
          <tr>
              <td scope="col">#</td>
              <td scope="col">Date</td>
              <td scope="col">Mileage</td>
              <td scope="col">Description</td>
          </tr>
      </thead>
      <tbody>
          <tr v-for="record in records" :key="record.recordId">
              <th scope="col">{{record.recordId}}</th>
              <td>{{record.date}}</td>
              <td>{{record.mileage}}</td>
              <td>{{record.description}}</td>
          </tr>
      </tbody>
  </table>
</template>

<script>
export default {
    props: {
        records: Object
    }
}
</script>

<style>

</style>