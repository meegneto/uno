﻿// eslint-disable-next-line @typescript-eslint/no-namespace
namespace Windows.Storage {

	export class ApplicationDataContainer {

		private static buildStorageKey(locality: string, key: string): string {
			return `UnoApplicationDataContainer_${locality}_${key}`;
		}
		private static buildStoragePrefix(locality: string): string {
			return `UnoApplicationDataContainer_${locality}_`;
		}

		/**
		 * Try to get a value from localStorage
		 * */
		private static tryGetValue(locality: string, key: string): any {
			const storageKey = ApplicationDataContainer.buildStorageKey(locality, key);

			try {
				if (localStorage.hasOwnProperty(storageKey)) {
					return { hasValue: true, value: localStorage.getItem(storageKey) };
				} else {
					return { hasValue: false, value: "" };
				}
			} catch (e) {
				console.debug(`ApplicationDataContainer.tryGetValue failed: ${e}`);
				return { hasValue: false, value: "" };
			}
		}

		/**
		 * Set a value to localStorage
		 * */
		private static setValue(locality: string, key: string, value: string) {
			try {
				const storageKey = ApplicationDataContainer.buildStorageKey(locality, key);

				localStorage.setItem(storageKey, value);
			} catch (e) {
				console.debug(`ApplicationDataContainer.setValue failed: ${e}`);
			}

			return true;
		}

		/**
		 * Determines if a key is contained in localStorage
		 * */
		private static containsKey(locality: string, key: string): boolean {
			const storageKey = ApplicationDataContainer.buildStorageKey(locality, key);

			try {
				return localStorage.hasOwnProperty(storageKey);
			} catch (e) {
				console.debug(`ApplicationDataContainer.containsKey failed: ${e}`);
			}

			return false;
		}

		/**
		 * Gets a key by index in localStorage
		 * */
		private static getKeyByIndex(locality: string, index: number): string {
			let localityIndex = 0;
			let returnKey = "";
			const prefix = ApplicationDataContainer.buildStoragePrefix(locality);

			try {
				for (let i = 0; i < localStorage.length; i++) {
					const storageKey = localStorage.key(i);

					if (storageKey.startsWith(prefix)) {

						if (localityIndex === index) {
							returnKey = storageKey.substr(prefix.length);
						}

						localityIndex++;
					}
				}
			} catch (e) {
				console.debug(`ApplicationDataContainer.getKeyByIndex failed: ${e}`);
			}

			return returnKey;
		}

		/**
		 * Determines the number of items contained in localStorage
		 * */
		private static getCount(locality: string): number {
			let count = 0;
			const prefix = ApplicationDataContainer.buildStoragePrefix(locality);

			try {
				for (let i = 0; i < localStorage.length; i++) {
					const storageKey = localStorage.key(i);

					if (storageKey.startsWith(prefix)) {
						count++;
					}
				}
			} catch (e) {
				console.debug(`ApplicationDataContainer.getCount failed: ${e}`);
			}

			return count;
		}

		/**
		 * Clears items contained in localStorage
		 * */
		private static clear(locality: string): void {
			const prefix = ApplicationDataContainer.buildStoragePrefix(locality);

			const itemsToRemove: string[] = [];

			try {
				for (let i = 0; i < localStorage.length; i++) {
					const storageKey = localStorage.key(i);

					if (storageKey.startsWith(prefix)) {
						itemsToRemove.push(storageKey);
					}
				}

				for (const item in itemsToRemove) {
					localStorage.removeItem(itemsToRemove[item]);
				}
			} catch (e) {
				console.debug(`ApplicationDataContainer.clear failed: ${e}`);
			}
		}

		/**
		 * Removes an item contained in localStorage
		 * */
		private static remove(locality: string, key: string): boolean {
			const storageKey = ApplicationDataContainer.buildStorageKey(locality, key);
			let removed = false;

			try {
				removed = localStorage.hasOwnProperty(storageKey);
			} catch (e) {
				removed = false;
				console.debug(`ApplicationDataContainer.remove failed: ${e}`);
			}

			if (removed) {
				localStorage.removeItem(storageKey);
			}

			return removed;
		}

		/**
		 * Gets a key by index in localStorage
		 * */
		private static getValueByIndex(locality: string, index: number): string {
			let localityIndex = 0;
			let returnValue = "";
			const prefix = ApplicationDataContainer.buildStoragePrefix(locality);

			try {
				for (let i = 0; i < localStorage.length; i++) {
					const storageKey = localStorage.key(i);

					if (storageKey.startsWith(prefix)) {

						if (localityIndex === index) {
							returnValue = localStorage.getItem(storageKey);
						}

						localityIndex++;
					}
				}
			} catch (e) {
				console.debug(`ApplicationDataContainer.getValueByIndex failed: ${e}`);
			}

			return returnValue;
		}

	}
}