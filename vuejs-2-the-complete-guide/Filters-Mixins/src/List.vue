<template>
    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3">
                <h1>Filters & Mixins</h1>
                <hr>

                <h2>Filter</h2>
                <ul>
                    <li v-for="fruit in fruits"> {{ fruit }}</li>
                </ul>
                <hr>
                <h2>Computed Property</h2>
                <input v-model="filterText">
                <ul>
                    <li v-for="fruit in filteredFruits"> {{ fruit }}</li>
                </ul>
            </div>
        </div>
    </div>
</template>

<script>

    import { fruitMixin } from './fruitMixin';

    export default {
        mixins: [fruitMixin],
        created() {
            console.log('Inside List Created Hook');
        }
    }
</script>

<style>

</style>
