<template>
	<div>
		<h1>Counter</h1>

		<p>This is a simple example of a VueX component.</p>

		<p aria-live="polite">
			Current count:
			<strong>{{ count }}</strong>
		</p>

		<button @click="increment">Increment</button>
		<button @click="decrement">Decrement</button>
	</div>
</template>

<script>
export default {
	computed: {
		count() {
			return this.$store.state.count;
		}
	},
	methods: {
		increment() {
			this.$store.commit("increment");
		},
		decrement() {
			this.$store.commit("decrement");
		}
	}
};
</script>
